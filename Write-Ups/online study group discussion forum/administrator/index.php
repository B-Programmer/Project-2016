<?php

session_start();
$_SESSION['images'] = '../public/uploads/images/';
$_SESSION['thumbs'] = '../public/uploads/.thumbs/images/';
$_SESSION['not'] = 2;
//error_reporting(0);

//Composer autoload
require_once('vendor/autoload.php');
require_once('app/database/connection.php');

if (!empty($_SESSION['code'])) {
    if (isset($_GET['controller']) && isset($_GET['action'])) {
        $controller = $_GET['controller'];
        $action = $_GET['action'];
        require_once('app/views/layout.php');
    } else {
        require_once 'app/views/security/login.php';
    }
} else {
    $_SESSION['code'] = '';
    require_once 'app/views/security/login.php';
}
