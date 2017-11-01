<?php

use Illuminate\Database\Capsule\Manager as Db;

class ForumUser {

    public static function all() {
        return Db::table('tbluser')->get();
    }

//	id 	username 	email 	last_visit 	online 	password 
    public static function create($uname, $email, $pword) {
        return Db::table('forumusers')->insert(
                        [
                            'username' => $uname,
                            'email' => $email,
                            'password' => md5($pword)
                        ]
        );
    }

    public static function delete($id) {
        return Db::table('forumusers')->delete($id);
    }

    public static function validateUser($uname, $pword) {
        return count(Db::table('forumusers')->where('username', $uname)->where('password', $pword)->first());
    }

    public static function find($id) {
        return Db::table('forumusers')->where('id', '=', $id)->first();
    }

    public static function update($uname, $pword, $id) {
        return Db::table('tbluser')->where('id', '=', $id)
                        ->update(
                                [
                                    'username' => $uname,
                                    'password' => $pword
                                ]
        );
    }

}
