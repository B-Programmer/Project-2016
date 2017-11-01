<?php

require_once '../../vendor/autoload.php';

class MainController {
    //put your code here
    public function home($pin) {
    	$pin = rtrim(chunk_split($pin,4,"-"), '-');
        echo json_encode(DrugVerification::verify_drug($pin));
    }
}

//Get The REQUEST
if(isset($_POST['userpin'])){
    $main = new MainController();
    $main->home($_POST['userpin']);
}



