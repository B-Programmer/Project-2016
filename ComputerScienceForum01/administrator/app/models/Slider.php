<?php

use Illuminate\Database\Capsule\Manager as Db;

class Slider {

    public static function all() {
        return Db::table('slider')->get();
    }

    public static function find($id) {
        return Db::table('slider')->where('id', $id)->first();
    }

    public static function store($caption, $description, $picture) {
        return Db::table('slider')->insert([
                    'caption' => $caption,
                    'description' => $description,
                    'picture' => $picture
        ]);
    }

    public static function update($id, $caption, $description, $picture) {
        return Db::table('slider')
                        ->where('id', $id)
                        ->update([
                            'caption' => $caption,
                            'description' => $description,
                            'picture' => $picture
        ]);
    }

    public static function delete($id) {
        return Db::table('slider')->delete($id);
    }

}
