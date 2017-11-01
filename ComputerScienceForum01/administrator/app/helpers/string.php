<?php

class Str {

    function __construct() {
        
    }

    public static function limit($str, $limit = 100, $strip = false) {
        $str = ($strip == true) ? strip_tags($str) : $str;
        if (strlen($str) > $limit) {
            $str = substr($str, 0, $limit - 3);
            return (substr($str, 0, strrpos($str, ' ')) . '...');
        }
        return trim($str);
    }

//    function limit($str, $limit=100) {
//        if (strlen($str) <= $limit)
//            return $str;
//
//        $newstr = substr($str, 0, $limit);
//        if (substr($newstr, -1, 1) != ' ')
//            $newstr = substr($newstr, 0, strrpos($newstr, " "));
//
//        return $newstr . ' ...';
//    }

    public static function slug($text) {
        if (str_word_count($text) > 0) {
            $text = str_replace(' ', '-', $text);
        }
        return $text;
    }

}
