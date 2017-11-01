<?php

session_start();
$_SESSION['images'] = '../public/uploads/images/';
$_SESSION['thumbs'] = '../public/uploads/.thumbs/images/';


//Composer autoload
require_once('vendor/autoload.php');
require_once('app/database/connection.php');

if (!empty($_SESSION['username'])) {
    if (isset($_GET['action'])) {
        $action = $_GET['action'];
    } else {
        $action = 'index';
    }
} else {
    $_SESSION['username'] = '';
    if (isset($_GET['action'])) {
        $action = $_GET['action'];
    } else {
        $action = 'index';
    }
}

require_once 'app/views/layout.php';


//if($_GET['page'] == 1){
//require_once 'app/views/layout.php';    
//}else if($_GET['page'] == 2){
//require_once 'app/views/viewforum.php';    
//}else if($_GET['page'] == 3){
//require_once 'app/views/viewtopic.php';    
//}else if($_GET['page'] == 4){
//require_once 'app/views/viewcategory.php';    
//}else if($_GET['page'] == 5){
//require_once 'app/views/reply.php';    
//}else if($_GET['page'] == 6){
//require_once 'app/views/loggedin.php';    
//}else if($_GET['page'] == 7){
//require_once 'app/views/register.php';    
//}else if($_GET['page'] == 8){
//require_once 'app/views/profile.php';    
//}else if($_GET['page'] == 9){
//    echo "Nothing Here!!!";
//}else{}
//
//
//
