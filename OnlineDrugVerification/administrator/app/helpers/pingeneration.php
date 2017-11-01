<?php

class PinGenerator {
    
    public static function generate() {
        $pin = '';
        for ($i = 0; $i < 3; $i++) {
            $pin .= random_int(1000, 9999) . '-';
        }
        $pin = rtrim($pin, '-');
        return $pin;
    }

}
