<?php

use Illuminate\Database\Capsule\Manager as Db;

class ForumForUser {

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

    public static function update($forum_id, $forum_last_post_id, $forum_last_poster_id, $forum_last_post_subject, $forum_last_post_time, $forum_last_poster_name) {
        return Db::table('forum')
                        ->where('id', $forum_id)
                        ->update([
                            'forum_last_post_id' => $forum_last_post_id,
                            'forum_last_poster_id' => $forum_last_poster_id,
                            'forum_last_post_subject' => $forum_last_post_subject,
                            'forum_last_post_time' => $forum_last_post_time,
                            'forum_last_poster_name' => $forum_last_poster_name
        ]);
    }

    public static function delete($id) {
        return Db::table('forum')->delete($id);
    }
}
