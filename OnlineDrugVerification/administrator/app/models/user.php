<?php

use Illuminate\Database\Capsule\Manager as Db;

class User {

    public static function all() {
        return Db::table('tbluser')->get();
    }

    public static function create($uname, $pword, $perm) {
        return Db::table('tbluser')->insert(
                        [
                            'username' => $uname,
                            'password' => $pword,
                            'permission' => $perm
                        ]
        );
    }

    public static function delete($id) {
        return Db::table('tbluser')->delete($id);
    }

    public function validateUser($uname, $pword) {
        return count(Db::table('tbluser')->where('username', $uname)->where('password', $pword)->first());
    }

    public static function find($id) {
        return Db::table('tbluser')->where('id', '=', $id)->first();
    }

    public static function update($uname, $pword, $perm, $id) {
        return Db::table('tbluser')->where('id', '=', $id)
                        ->update(
                                [
                                    'username' => $uname,
                                    'password' => $pword,
                                    'permission' => $perm
                                ]
        );
    }

}
