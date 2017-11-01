<h1>Welcome</h1>
<?php

//Compooser Autoload
require_once ('vendor/autoload.php');

//Load Database Connection
require_once('app/database/connection.php');

//Load Routes
require_once('app/views/index.html');

//$route = new Router();
//$route->add('/');
//$route->add('/home');
//
//$route->submit();