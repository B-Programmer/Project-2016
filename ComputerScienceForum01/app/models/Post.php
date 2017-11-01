<?php

use Illuminate\Database\Capsule\Manager as Db;

class PostForUser {

    public static function all() {
        return Db::table('posts')->get();
    }

    public static function findById($id) {
        return Db::table('posts')->where('id', $id)->first();
    }

    public static function findLatest() {
        return Db::table('posts')->orderBy('posted_at', 'desc')->first();
    }

    public static function countById($fid) {
        return Db::table('posts')->where('forum_id', $fid)->get();
    }

    public static function countByTopicId($tid) {
        return Db::table('posts')->where('topic_id', $tid)->get();
    }

    public static function findByForum($id) {
        return Db::table('posts')->where('forum_id', $id)->get();
    }

    public static function findByTopic($id) {
        return Db::table('posts')->where('topic_id', $id)->get();
    }

    public static function store($topic_id, $forum_id, $subject, $content, $poster, $reply_id) {
        return Db::table('posts')
                        ->insert([
                            'topic_id' => $topic_id,
                            'forum_id' => $forum_id,
                            'subject' => $subject,
                            'content' => $content,
                            'poster' => $poster,
                            'reply_id' => $reply_id
        ]);
    }

    public static function delete($id) {
        return Db::table('posts')->delete($id);
    }

}
