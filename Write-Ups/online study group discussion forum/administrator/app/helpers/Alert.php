<?php

class Alert {

    public static function init($notification = 2) {
        if ($notification == 1) {
            return self::success();
        } elseif ($notification == 0) {
            return self::error();
        } else {
            return '';
        }
    }

    private static function success($title = 'SUCCESS', $message = 'Operation was successful') {
        echo "title: '".$title."',
            text: '".$message."',
            type: 'success',
            styling: 'bootstrap3'";
    }

    private static function error($title = 'ERROR', $message = 'Operation failed.') {
        echo "
            title: '".$title."',
            text: '".$message."',
            type: 'danger',
            styling: 'bootstrap3'
        ";
    }

    private static function warning($title = 'WARNING', $message = 'Something might go wrong.') {
        echo "
            title: '".$title."',
            text: '".$message."',
            type: 'warning',
            styling: 'bootstrap3'
        ";
    }

    private static function info($title = 'INFORMATION', $message = 'This is just a notification.') {
        echo "
            title: '".$title."',
            text: '".$message."',
            type: 'info',
            styling: 'bootstrap3'
        ";
    }

}
