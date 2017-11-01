<?php

use Smarty as View;

class TopicController {

    public function __construct() {
        $this->view = new View;
    }

    public function index($notification = 2) {
        $_SESSION['not'] = $notification;
        $topics = Topic::all();
        $this->view->assign('topics', $topics);
        $this->view->assign('thumbs_url', $_SESSION['thumbs']);
        $this->view->display('./app/views/topic/index.tpl');
    }

    public function create() {
        $this->view->assign('forums', Forum::all());
        $this->view->display('./app/views/topic/create.tpl');
    }

    public function edit() {
        $id = intval($_GET['id']);
        $this->view->assign('topic', Topic::find($id));
        $this->view->assign('forums', Forum::all());
        $this->view->display('./app/views/topic/edit.tpl');
    }

    public function store() {
        $post_var = array_values($_POST);
        if (count($post_var) == 0) {
            self::index(0);
        } else {
            self::index(Topic::store($post_var[0], $post_var[1], $post_var[2]));
        }
    }

    public function update() {
        $post_var = array_values($_POST);
        if (count($post_var) == 0) {
            self::index(0);
        } else {
            self::index(Topic::update($post_var[0], $post_var[1], $post_var[2], $post_var[3]));
        }
    }

    public function delete() {
        $id = intval($_GET['id']);
        self::index(Topic::delete($id));
    }

}
