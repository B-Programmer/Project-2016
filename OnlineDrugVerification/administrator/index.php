<?php

session_start();
//error_reporting(0);

//Composer autoload
require_once('vendor/autoload.php');
require_once('app/database/connection.php');

if (!empty($_SESSION['username'])) {
    if (isset($_GET['controller']) && isset($_GET['action'])) {
        $controller = $_GET['controller'];
        $action = $_GET['action'];
        require_once('app/views/layout.php');
    } else {
        require_once 'app/views/security/login.php';
    }
} else {
    $_SESSION['username'] = '';
    require_once 'app/views/security/login.php';
}
