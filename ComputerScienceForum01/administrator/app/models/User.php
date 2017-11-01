<?php

use Illuminate\Database\Capsule\Manager as Db;

class User {

    public static function all() {
        return Db::table('users')->get();
    }

    public static function create($uname, $pword) {
        return Db::table('users')->insert([
                    'username' => $uname,
                    'password' => $pword
        ]);
    }

    public static function delete($id) {
        return Db::table('users')->delete($id);
    }

    public function validateUser($uname, $pword) {
        return count(Db::table('users')->where('username', $uname)->where('password', $pword)->first());
    }

    public static function find($id) {
        return Db::table('users')->where('id', '=', $id)->first();
    }

    public static function update($uname, $pword, $id) {
        return Db::table('users')
                        ->where('id', '=', $id)
                        ->update([
                            'username' => $uname,
                            'password' => $pword
        ]);
    }

}
