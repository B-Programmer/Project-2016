<?php

use Illuminate\Database\Capsule\Manager as Db;

class Forum {

    public static function all() {
        return Db::table('forum')->get();
    }

    public static function find($id) {
        return Db::table('forum')->where('id', $id)->first();
    }

    public static function store($name, $desc) {
        return Db::table('forum')
                        ->insert([
                            'forum_name' => $name,
                            'forum_desc' => $desc
        ]);
    }

    public static function update($id, $name, $desc) {
        return Db::table('forum')
                        ->where('id', $id)
                        ->update([
                            'forum_name' => $name,
                            'forum_desc' => $desc
        ]);
    }

    public static function delete($id) {
        return Db::table('forum')->delete($id);
    }

}
