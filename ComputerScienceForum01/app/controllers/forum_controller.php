<?php

use Smarty as View;

class ForumController {

    public function __construct() {
        $this->view = new View;
    }

    public function register() {
        require_once 'app/views/register.php';
    }

    public function login() {
        require_once 'app/views/login.php';
    }

    public function user_register() {
        $post_var = array_values($_POST);

        try {
            if (ForumUser::create($post_var[0], $post_var[1], $post_var[2]) == 1) {
//            Load SESSION
                $_SESSION['code'] = $post_var[0];
                $_SESSION['email'] = $post_var[1];

//            Check action where register even is made so u can refer the user back there
                $cur_page = 'index';
                self::index();
            }
        } catch (PDOException $exc) {
            
        }
    }

    public function user_login() {
        $post_var = array_values($_POST);
        if (ForumUser::validateUser($post_var[0], md5($post_var[1])) == 1) {
            $_SESSION['code'] = $post_var[0];
            self::index();
        } else {
            echo '<bb>Error Logging in</b>';
//            return error
        }
    }

    public function index() {
        require_once 'app/views/home.php';
    }

    public function store() {
        $post_var = array_values($_POST);
        if (count($post_var) == 0) {
            self::index(0);
        } else {
            self::index(ForumForUser::store($post_var[0], $post_var[1]));
        }
    }

    public function viewforum() {
        $id = $_GET['forum_id'];
        $topiclist = TopicForUser::findByForum($id);
        $forum = ForumForUser::find($id);
        require_once 'app/views/viewforum.php';
    }

    public function viewtopic() {
        $id = $_GET['topic_id'];
        $topics = PostForUser::findByTopic($id);
        $topic = TopicForUser::find($id);
        require_once 'app/views/viewtopic.php';
    }

    public function new_topic() {
        $id = $_GET['forum_id'];
        $forum = ForumForUser::find($id);

        if (empty($_SESSION['code'])) {
            require_once 'app/views/login.php';
        } else {
            require_once 'app/views/reply.php';
        }
    }

    public function save_new_topic() {
        $post_var = array_values($_POST);
        $forum_id = $_GET['forum_id'];
        if (isset($_GET['reply_id'])) {
            $reply_id = $_GET['reply_id'];
        } else {
            $reply_id = 0;
        }
        try {
            TopicForUser::store($post_var[0], $post_var[2], $forum_id);
            //        Set this forum content as a post
//            Find the latest topic that was created
            $latest_topic = TopicForUser::findLatest();

            PostForUser::store($latest_topic->id, $forum_id, $post_var[0], $post_var[2], $_SESSION['code'], $reply_id);

            $latestpost = PostForUser::findLatest();
//            Update forum table
            ForumForUser::update($forum_id, $latestpost->id, 1, $latestpost->subject, $latestpost->posted_at, $latestpost->poster);
            self::viewforum();
        } catch (PDOException $exc) {
            die("Exception Caught " . $exc);
        }
    }

//You need to login in order to post within this forum.
    public function new_reply() {
        $tid = $_GET['topic_id'];
        $fid = $_GET['forum_id'];
        $topic = TopicForUser::find($tid);
        $topics = PostForUser::findByTopic($tid);

        if (empty($_SESSION['code'])) {
            require_once 'app/views/login.php';
        } else {
            require_once 'app/views/reply.php';
        }
    }

    public function save_new_reply() {
        $post_var = array_values($_POST);
        $topic_id = $_GET['topic_id'];
        $forum_id = $_GET['forum_id'];
        $subject = $post_var[0];
        $content = $post_var[2];
        $poster = $_SESSION['code'];
        if (isset($_GET['reply_id'])) {
            $reply_id = $_GET['reply_id'];
        } else {
            $reply_id = 0;
        }

        try {
            PostForUser::store($topic_id, $forum_id, $subject, $content, $poster, $reply_id);

//            Get The last post id;
            $latestpost = PostForUser::findLatest();

//            Update Topics Poster
            TopicForUser::update($latestpost->topic_id);

//            Update forum table
            ForumForUser::update($forum_id, $latestpost->id, 1, $latestpost->subject, $latestpost->posted_at, $latestpost->poster);
            self::viewtopic();
        } catch (PDOException $exc) {
            die("Exception Caught " . $exc);
        }
    }
}
