<?php

use Smarty as View;

class PostController {

    private $view;

    public function __construct() {
        $this->view = new View;
    }

    public function index($notification = 2) {
        $_SESSION['not'] = $notification;
        $posts = Post::all();
        $this->view->assign('posts', $posts);
        $this->view->assign('thumbs_url', $_SESSION['thumbs']);
        $this->view->display('./app/views/post/index.tpl');
    }

    public function create() {
        $this->view->assign('forums', Forum::all());
//        Get Post From Selected Forum
        $this->view->assign('posts', Post::all());
        $this->view->display('./app/views/post/create.tpl');
    }

    public function edit() {
        $id = intval($_GET['id']);
        $post = Post::find($id);
        $this->view->assign('forums', Forum::all());
//        Get Post From Selected Forum
        $this->view->assign('posts', Post::all());
        $this->view->assign('post', $post);
        $this->view->display('./app/views/post/edit.tpl');
    }

    public function store() {
        $post_var = array_values($_POST);
        if (count($post_var) == 0) {
            self::index(0);
        } else {
            self::index(Post::store($post_var[1], $post_var[0], $post_var[3], '0', $post_var[2]));
        }
    }

    public function update() {
        $post_var = array_values($_POST);
        if (count($post_var) == 0) {
            self::index(0);
        } else {
            self::index(Post::update($post_var[0], $post_var[1], $post_var[2], $post_var[3]));
        }
    }

    public function delete() {
        $id = intval($_GET['id']);
        self::index(Post::delete($id));
    }

}
