<?php

use Illuminate\Database\Capsule\Manager as Db;

class About {

    public static function all($id = 1) {
        return Db::table('about')
                ->where('id', $id)
                ->first();
    }
    
    public static function update($id, $content) {
        return Db::table('about')->where('id', $id)
                ->update([
                    'content' => $content
                ]);
    }
    
}
