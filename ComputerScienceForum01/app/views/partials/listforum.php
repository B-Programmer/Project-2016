
<div class="forabg">
    <div class="inner">
        <ul class="topiclist">
            <li class="header">
                <dl class="icon">
                    <dt><div class="list-inner"><a href="#">Your first category</a></div></dt>
                    <dd class="topics">Topics</dd>
                    <dd class="posts">Posts</dd>
                    <dd class="lastpost"><span>Last post</span></dd>
                </dl>
            </li>
        </ul>
        <?php
        $forums = ForumForUser::all();
        foreach ($forums as $forum) {
            $no_of_topics = count(TopicForUser::countById($forum->id));
            $no_of_posts = count(PostForUser::countById($forum->id));
//            Get the post information
            $postInfo = PostForUser::findById($forum->forum_last_post_id);
            ?>
            <ul class="topiclist forums">
                <li class="row">
                    <dl class="icon forum_read">
                        <dt title="No unread posts">
                        <div class="list-inner">
                            <a href="?action=viewforum&forum_id=<?php echo $forum->id ?>" class="forumtitle"><?php echo $forum->forum_name ?></a>
                            <br /><?php echo $forum->forum_desc ?>												
                        </div>
                        </dt>
                        <dd class="topics"><?php echo $no_of_topics; ?> <dfn>Topics</dfn></dd>
                        <dd class="posts"><?php echo $no_of_posts; ?> <dfn>Posts</dfn></dd>
                        <?php if($no_of_topics != 0) { ?>
                            <dd class="lastpost"><span>
                                    <dfn>Last post</dfn>
                                    <a href="?action=viewtopic&forum_id=<?php echo $postInfo->forum_id ?>&topic_id=<?php echo $postInfo->topic_id ?>#p<?php echo $postInfo->id ?>" title="<?php echo $forum->forum_last_post_subject ?>" class="lastsubject"><?php echo $forum->forum_last_post_subject ?></a> <br />

                                    by <a href="#" style="color: #AA0000;" class="username-coloured"><?php echo $forum->forum_last_poster_name ?></a>
                                    <a href="?action=viewtopic&forum_id=<?php echo $postInfo->forum_id ?>&topic_id=<?php echo $postInfo->topic_id ?>"><span class="imageset icon_topic_latest" title="View the latest post">View the latest post</span></a> <br /><?php echo $forum->forum_last_post_time ?></span>
                            </dd>
                        <?php } ?>
                    </dl>
                </li>
            </ul>
        <?php } ?>
    </div>
</div>