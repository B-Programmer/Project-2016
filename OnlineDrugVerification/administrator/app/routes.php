<?php

//function call($controller, $action) {
//
//    require_once('controllers/' . $controller . '_controller.php');
//
//    switch ($controller) {
//        case 'drug':
//            require_once 'app/models/drug.php';
//            $controller = new DrugController();
//            break;
//        case 'settings':
//            require_once 'app/models/user.php';
//            $controller = new SettingsController();
//            break;
//    }
//
//
//    $controller->{ $action }();
//}
//
//$controllers = array(
//    'drug' => ['index', 'create', 'edit', 'addnew', 'update', 'delete','error'],
//    'settings' => ['index', 'create', 'user_edit', 'user_create', 'user_delete', 'user_update'],
//);
//
//if (array_key_exists($controller, $controllers)) {
//    if (in_array($action, $controllers[$controller])) {
//        call($controller, $action);
//    } else {
//        call('pages', 'error');
//    }
//} else {
//    call('pages', 'error');
//}
//
//
//


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
      $tmp_controller = $controller = 'main';

      //REQUIRE THE CONTROLLER
      require_once('controllers/' . $controller . '_controller.php');
    }
  }else {
    //If Controller is not set
    $tmp_controller = 'main';
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
      $tmp_action = 'home';
    }
  }

  $controller->{ $tmp_action }();
}
