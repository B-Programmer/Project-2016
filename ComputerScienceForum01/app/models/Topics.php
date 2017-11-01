<?php

use Illuminate\Database\Capsule\Manager as Db;

class TopicForUser {

    public static function all() {
        return Db::table('topics')->get();
    }

    public static function find($id) {
        return Db::table('topics')->where('id', $id)->first();
    }

    public static function findLatest() {
        return Db::table('topics')->orderBy('created_at', 'desc')->first();
    }

    public static function findByForum($id) {
        return Db::table('topics')->where('forum_id', $id)->get();
    }

    public static function store($name, $desc, $forum_id) {
        return Db::table('topics')
                        ->insert([
                            'forum_id' => $forum_id,
                            'subject' => $name,
                            'content' => $desc,
                            'last_poster' => $_SESSION['code'],
                            'created_by' => $_SESSION['code']
        ]);
    }

    public static function delete($id) {
        return Db::table('topics')->delete($id);
    }

    public static function countById($fid) {
        return Db::table('topics')->where('forum_id', $fid)->get();
    }

    public static function update($id) {
        return Db::table('topics')->where('id', $id)->update(
                        [
                            'last_poster' => $_SESSION['code']
                        ]
        );
    }

}
