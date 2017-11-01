<?php

use Illuminate\Database\Capsule\Manager as Db;

class Post {

    public static function all() {
        return Db::table('posts')->get();
    }

    public static function find($id) {
//->where('id', $id)->first();
        return Db::table('posts')
                        ->join('forum', 'posts.forum_id', '=', 'forum.id')
                        ->join('topics', 'posts.topic_id', '=', 'topics.id')
                        ->select('posts.*', 'forum.forum_name', 'topics.subject')
                        ->get();
    }

    public static function findAll($id) {
        return Db::table('posts')->where('topic_id', $id)->get();
    }

    public static function store($topic_id, $forum_id, $content, $poster_id, $reply_id) {
        return Db::table('posts')
                        ->insert([
                            'topic_id' => $topic_id,
                            'forum_id' => $forum_id,
                            'content' => $content,
                            'poster_id' => $poster_id,
                            'reply_id' => $reply_id
        ]);
    }

    public static function update($id, $name, $desc) {
        return Db::table('posts')
                        ->where('id', $id)
                        ->update([
                            'posts_name' => $name,
                            'posts_desc' => $desc
        ]);
    }

    public static function delete($id) {
        return Db::table('posts')->delete($id);
    }

}
