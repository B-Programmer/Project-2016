<?php

use Illuminate\Database\Capsule\Manager as Db;

class Trustee {

    public static function all() {
        return Db::table('trustees')->get();
    }

    public static function find($id) {
        return Db::table('trustees')->where('id', $id)->first();
    }

    public static function store($fullname, $position, $socialnetworks, $bio, $picture) {
        return Db::table('trustees')->insert([
                    'fullname' => $fullname,
                    'position' => $position,
                    'socialnetworks' => $socialnetworks,
                    'bio' => $bio,
                    'picture' => $picture
        ]);
    }

    public static function update($id, $fullname, $position, $socialnetworks, $bio, $picture) {
        return Db::table('trustees')
                        ->where('id', $id)
                        ->update([
                            'fullname' => $fullname,
                            'position' => $position,
                            'socialnetworks' => $socialnetworks,
                            'bio' => $bio,
                            'picture' => $picture
        ]);
    }

    public static function delete($id) {
        return Db::table('trustees')->delete($id);
    }

}
