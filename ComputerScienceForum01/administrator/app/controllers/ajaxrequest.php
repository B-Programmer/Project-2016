<?php

require_once '../../vendor/autoload.php';
require_once '../database/connection.php';

class AjaxRequest {

    public function getTopics($id) {
        echo json_encode(Topic::findAll($id));
    }

    public function getPosts($id) {
        echo json_encode(Post::findAll($id));
    }

}

//Get The REQUEST
if (isset($_POST['forum_id'])) {
    $req = new AjaxRequest();
    $req->getTopics($_POST['forum_id']);
}
if (isset($_POST['topic_id'])) {
    $req = new AjaxRequest();
    $req->getPosts($_POST['topic_id']);
}
