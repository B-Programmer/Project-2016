<?php
session_start();

require_once ('../../vendor/autoload.php');
require_once ('../database/connection.php');
require_once ('../models/user.php');

$username = $_POST['username'];
$password = $_POST['password'];

$user = new User(NULL, NULL, NULL, NULL);
if ($user->validateUser($username, md5($password)) == 1) {
    $_SESSION['code'] = $username;
    header('location: ../../index.php?controller=forum&action=index');
    exit();
} else {
    header('location: ../../index.php?errorCode=1');
    exit();
}