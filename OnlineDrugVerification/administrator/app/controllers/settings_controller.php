<?php

class SettingsController {

    function index() {
        $users = User::all();
        require_once 'app/views/settings/index.php';
    }

    function user_delete() {
        $id = intval($_GET['id']);
        $user = User::delete($id);
        session_destroy();
        self::index();
    }

    function user_edit() {
        $users = User::all();
        $auser = User::find($_GET['id']);
        require_once 'app/views/settings/index.php';
    }

    function user_create() {
        $post_var = array_values($_POST);
        $user = User::create($post_var[0], md5($post_var[1]), $post_var[2]);
        session_destroy();
        self::index();
    }

    function user_update() {
        $post_var = array_values($_POST);
        $id = intval($_GET['id']);
        $user = User::update($post_var[0], md5($post_var[1]), $post_var[2], $id);
        session_destroy();
        self::index();
    }

}
