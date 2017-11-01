<?php


call($controller, $action);
  //My New Route Controller
  
  //CHECK IF THE CONTROLLER EXISTS
function call($controller, $action)
{
  $tmp_controller = "";
  $tmp_action = "";

  if (isset($controller)) {
    if (file_exists('app/controllers/' . $controller . '_controller.php')) {

      $tmp_controller = $controller;

      //REQUIRE THE CONTROLLER
      require_once('controllers/' . $controller . '_controller.php');

    }else{
      $tmp_controller = $controller = 'forum';

      //REQUIRE THE CONTROLLER
      require_once('controllers/' . $controller . '_controller.php');
    }
  }else {
    //If Controller is not set
    $tmp_controller = 'forum';
  }

  //Create an object with the controller
  $controller_obj = ucfirst($controller) . 'Controller';

  $controller = new $controller_obj;

  //CHECK IF METHOD EXISTS IN THE CONTROLLER
  if(isset($action))
  {
    if(method_exists($controller, $action))
    {
      $tmp_action = $action;
    }else{
      $tmp_action = 'index';
    }
  }

  $controller->{ $tmp_action }();
}
