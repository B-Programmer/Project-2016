<?php
session_start();

require_once '../../vendor/autoload.php';
require_once '../database/connection.php';

$username = $_POST['username'];
$password = $_POST['password'];

$user = new User();
if ($user->validateUser($username, md5($password)) == 1) {
    $_SESSION['username'] = $username;
    header('location: ../../index.php?controller=drug&action=index');
    exit();
} else {
    header('location: ../../index.php?errorCode=1');
    exit();
}