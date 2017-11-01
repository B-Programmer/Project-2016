<?php

//use Illuminate\Database\Capsule\Manager as Capsule;
//
//$capsule = new Capsule();
//
//$capsule->addConnection([
//    'driver'    => 'mysql',
//    'host'      => 'localhost',
//    'database'  => 'drugverification',
//    'username'  => 'root',
//    'password'  => 'vertrigo',
//    'charset'   => 'utf8',
//    'collation' => 'utf8_unicode_ci',
//    'prefix'    => '',
//]);
//
//
//// Make this Capsule instance available globally via static methods... (optional)
//$capsule->setAsGlobal();
//
//// Setup the Eloquent ORM... (optional; unless you've used setEventDispatcher())
//$capsule->bootEloquent();
//

class Db {

    private static $instance = NULL;

    private function __construct() {
        
    }

    private function __clone() {
        
    }

    public static function getInstance() {
        if (!isset(self::$instance)) {

            self::$instance = new mysqli('localhost', 'root', 'vertrigo', 'drugverification');
        }
        return self::$instance;
    }

}
