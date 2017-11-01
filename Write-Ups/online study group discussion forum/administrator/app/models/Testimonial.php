<?php

use Illuminate\Database\Capsule\Manager as Db;

class Testimonial {

    public static function all() {
        return Db::table('testimonials')->get();
    }

    public static function find($id) {
        return Db::table('testimonials')->where('id', $id)->first();
    }

    public static function store($fullname, $portfolio, $testimony, $picture) {
        return Db::table('testimonials')->insert([
                    'fullname' => $fullname,
                    'portfolio' => $portfolio,
                    'testimony' => $testimony,
                    'picture' => $picture
        ]);
    }

    public static function update($id, $fullname, $portfolio, $testimony, $picture) {
        return Db::table('testimonials')
                        ->where('id', $id)
                        ->update([
                            'fullname' => $fullname,
                            'portfolio' => $portfolio,
                            'testimony' => $testimony,
                            'picture' => $picture
        ]);
    }

    public static function delete($id) {
        return Db::table('testimonials')->delete($id);
    }

}
