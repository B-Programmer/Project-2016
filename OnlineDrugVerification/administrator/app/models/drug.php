<?php

use Illuminate\Database\Capsule\Manager as Db;

class Drug {

    public static function create($title, $production_date, $expiry_date, $pin) {
        return Db::table('druginfo')->insert(
                        [
                            'title' => $title,
                            'production_date' => $production_date,
                            'expiry_date' => $expiry_date,
                            'pin' => $pin
                        ]
        );
    }

    public static function all() {
        return Db::table('druginfo')->get();
    }

    public static function delete($id) {
        return Db::table('druginfo')->delete($id);
    }

    public static function find($id) {
        return Db::table('druginfo')->where('id', $id)->first();
    }

    public static function update($id, $title, $production_date, $expiry_date) {
        return Db::table('druginfo')->where('id', $id)
                        ->update(
                                [
                                    'title' => $title,
                                    'production_date' => $production_date,
                                    'expiry_date' => $expiry_date
                                ]
        );
    }

    public static function pin_exists($pin) {
        return Db::table('druginfo')->where('pin', $pin)->first();
    }

}
