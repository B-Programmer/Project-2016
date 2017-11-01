<?php

class DrugController {

    function index() {
        $drug = Drug::all();
        require_once 'app/views/drug/index.php';
    }

    function edit() {
        $id = intval($_GET['id']);
        $drug = Drug::find($id);
        require_once 'app/views/drug/edit.php';
    }

    function create() {

        $tmp_pin = PinGenerator::generate();
        if (static::pin_exists($tmp_pin)) {
            self::create();
        } else {
            $pin = $tmp_pin;
        }
        $drug = Drug::all();
        require_once 'app/views/drug/create.php';
    }

    function addnew() {
        $post_var = array_values($_POST);
        Drug::create($post_var[0], $post_var[1], $post_var[2], $post_var[3]);
        self::index();
    }

    function update() {
        $id = intval($_GET['id']);
        $post_var = array_values($_POST);
        Drug::update($id, $post_var[0], $post_var[1], $post_var[2]);
        self::index();
    }

    function delete() {
        $id = intval($_GET['id']);
        Drug::delete($id);
        self::index();
    }

    protected function pin_exists($pin) {
        return Drug::pin_exists($pin);
    }

}
