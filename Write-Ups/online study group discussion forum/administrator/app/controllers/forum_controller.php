<?php

use Smarty as View;

class ForumController {

    public function __construct() {
        $this->view = new View;
    }

    public function index($notification = 2) {
        $_SESSION['not'] = $notification;
        $forums = Forum::all();
        $this->view->assign('forums', $forums);
        $this->view->assign('thumbs_url', $_SESSION['thumbs']);
        $this->view->display('./app/views/forum/index.tpl');
    }

    public function create() {
        $this->view->display('./app/views/forum/create.tpl');
    }

    public function edit() {
        $id = intval($_GET['id']);
        $forum = Forum::find($id);
        $this->view->assign('forum', $forum);
        $this->view->display('./app/views/forum/edit.tpl');
    }

    public function store() {
        $post_var = array_values($_POST);
        if (count($post_var) == 0) {
            self::index(0);
        } else {
            self::index(Forum::store($post_var[0], $post_var[1]));
        }
    }

    public function update() {
        $post_var = array_values($_POST);
        if (count($post_var) == 0) {
            self::index(0);
        } else {
            self::index(Forum::update($post_var[0], $post_var[1], $post_var[2]));
        }
    }

    public function delete() {
        $id = intval($_GET['id']);
        self::index(Forum::delete($id));
    }

}


