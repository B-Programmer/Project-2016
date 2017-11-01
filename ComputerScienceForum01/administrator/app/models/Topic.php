<?php

use Illuminate\Database\Capsule\Manager as Db;

class Topic {

    public static function all() {
        return Db::table('topics')->get();
    }

    public static function findAll($id) {
        return Db::table('topics')->where('forum_id', $id)->get();
    }

    public static function find($id) {
        return Db::table('topics')->where('id', $id)->first();
    }

    public static function store($forum_id, $subject, $content) {
        return Db::table('topics')
                        ->insert([
                            'forum_id' => $forum_id,
                            'subject' => $subject,
                            'content' => $content
        ]);
    }

    public static function update($id, $forum_id, $subject, $content) {
        return Db::table('topics')
                        ->where('id', $id)
                        ->update([
                            'forum_id' => $forum_id,
                            'subject' => $subject,
                            'content' => $content
        ]);
    }

    public static function delete($id) {
        return Db::table('topics')->delete($id);
    }

}
