<?php

class Mailer {

    public static function sendMail($post_var) {


        $n = htmlspecialchars($post_var['name']);
        $em = htmlspecialchars($post_var['email']);
        $pn = htmlspecialchars($post_var['phone']);
        $m = htmlspecialchars($post_var['message']);

        $to = "admin@creativedemschools.com";

        $headers = "From: " . $n . " Email Address: " . $em;

        $subject = "From Creativedemschools.com Contact Us Page";

        $message = "Name: " . $n . "\nEmail: " . $em . "\nPhone Number: " . $pn . "\nMessage: " . $m . "\n";

        mail($to, $subject, $message, $headers);

        $to = "info@creativedemschools.com";

        if(mail($to, $subject, $message, $headers)){
        	return true;
        }else{
        	return false;
        }
        
    }

}
