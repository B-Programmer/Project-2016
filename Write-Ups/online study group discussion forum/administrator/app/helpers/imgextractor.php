<?php

class ImgExtractor {

    public static function extractor($string) {
        $doc = new DOMDocument();
        $doc->loadHTML($string);
        $xpath = new DOMXPath($doc);
        $src = $xpath->evaluate("string(//img/@src)");
        return $src;
    }

}
