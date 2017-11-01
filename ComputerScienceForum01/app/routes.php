<?php

call($action);

function call($action = 'index') {
    $controller = 'forum';
    //Create an object with the controller
    $controller_obj = ucfirst($controller) . 'Controller';

    $controller = new $controller_obj;

    //CHECK IF METHOD EXISTS IN THE CONTROLLER
    if (isset($action)) {
        if (!method_exists($controller, $action)) {
            $action = 'index';
        }
    } else {
        $action = 'index';
    }

    $controller->{ $action }();
}
