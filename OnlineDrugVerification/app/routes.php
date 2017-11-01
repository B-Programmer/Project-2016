<?php

// My Router
class Router {

    private $_uri = [];
    private $_method = [];

    /**
     * Builds a collection of internal url's to look for
     * @param type $url link
     */
    public function add($uri, $method = NULL) {
        $this->_uri[] = '/' . trim($uri, '/');

        if ($method != NULL) {
            $this->_method[] = $method;
        }
    }

    public function submit() {
        echo $uriGetParam = isset($_GET['uri']) ? '/' . $_GET['uri'] : '/';
        echo '<br>'. $uriGetParam2 = isset($_GET['uri2']) ? '/' . $_GET['uri2'] : '/';
        echo '<br>'. $uriGetParam3 = isset($_GET['uri3']) ? '/' . $_GET['uri3'] : '/';
        echo '<br>';
        
        die();
        foreach ($this->_uri as $key=>$value) {
            if (preg_match("#^$value$#", $uriGetParam)) {
//                $useMethod = $this->_method[$key];
//                new $useMethod();

//                call_user_func($this->_method[$key]);
            }
        }
    }

}

//call($controller, $action);
//  //My New Route Controller
//  
//  //CHECK IF THE CONTROLLER EXISTS
//function call($controller, $action)
//{
//  $tmp_controller = "";
//  $tmp_action = "";
//
//  if (isset($controller)) {
//    if (file_exists('app/controllers/' . $controller . '_controller.php')) {
//
//      $tmp_controller = $controller;
//
//      //REQUIRE THE CONTROLLER
//      require_once('controllers/' . $controller . '_controller.php');
//
//    }else{
//      $tmp_controller = $controller = 'main';
//
//      //REQUIRE THE CONTROLLER
//      require_once('controllers/' . $controller . '_controller.php');
//    }
//  }else {
//    //If Controller is not set
//    $tmp_controller = 'main';
//  }
//
//  //Create an object with the controller
//  $controller_obj = ucfirst($controller) . 'Controller';
//
//  $controller = new $controller_obj;
//
//  //CHECK IF METHOD EXISTS IN THE CONTROLLER
//  if(isset($action))
//  {
//    if(method_exists($controller, $action))
//    {
//      $tmp_action = $action;
//    }else{
//      $tmp_action = 'home';
//    }
//  }
//
//  $controller->{ $tmp_action }();
//}
