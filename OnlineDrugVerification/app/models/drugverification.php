<?php

require_once '../../vendor/autoload.php';
require_once '../database/connection.php';
class DrugVerification {

    public $name;
    public $prod_date;
    public $exp_date;
    public $id;

    function __construct($id, $name, $prod_date, $exp_date) {
        $this->id = $id;
        $this->name = $name;
        $this->prod_date = $prod_date;
        $this->exp_date = $exp_date;
    }

    public static function verify_drug($pin) {
        $db = Db::getInstance();

        $req = $db->prepare('SELECT id, title, production_date, expiry_date FROM druginfo WHERE pin = ?');

        // the query was prepared, now we replace :id with our actual $id value
        /* bind parameters for markers */
        $req->bind_param("s", $pin);

        /* execute query */
        $req->execute();

        /* bind result variables */
        $req->bind_result($id, $name, $prod_date, $exp_date);

        /* fetch value */
        $req->fetch();
        $req->close();
        return new DrugVerification($id, $name, $prod_date, $exp_date);
    }

}
