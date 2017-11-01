<?php foreach ($topics as $topic) { ?>
    <div id="p1" class="post has-profile bg2">
        <div class="inner">

            <div class="postbody">
                <div id="post_content1">

                    <h3 class="first"><a href="#p<?php echo $topic->id ?>"><?php echo $topic->subject ?></a></h3>

                    <p class="author"><a href="#"><span class="imageset icon_post_target" title="Post">Post</span></a><span class="responsive-hide">by <strong><a href="#" style="color: #AA0000;" class="username-coloured"><?php echo $topic->poster ?></a></strong> &raquo; </span>Thu Sep 29, 2016 5:32 pm </p>

                    <div class="content"><?php echo $topic->content ?></div>

                </div>

            </div>

            <div class="back2top"><a href="#top" class="top" title="Top">Top</a></div>

        </div>
    </div>

<?php } ?>