<div class="forumbg">
    <div class="inner">
        <ul class="topiclist">
            <li class="header">
                <dl class="icon">
                    <dt><div class="list-inner">Topics</div></dt>
                    <dd class="posts">Replies</dd>
                    <dd class="lastpost"><span>Last post</span></dd>
                </dl>
            </li>
        </ul>

        <?php
        foreach ($topiclist as $topic) {

            $no_of_replies = count(PostForUser::countByTopicId($topic->id));
//            Get the post information
            $forum = ForumForUser::find($topic->forum_id);

            $postInfo = PostForUser::findById($forum->forum_last_post_id);
            ?>
            <ul class="topiclist topics">

                <li class="row bg1">
                    <dl class="icon topic_read">
                        <dt title="No unread posts">
                        <div class="list-inner">
                            <a href="?action=viewtopic&forum_id=<?php echo $topic->forum_id ?>&topic_id=<?php echo $topic->id ?>" class="topictitle"><?php echo $topic->subject ?></a>
                            <br />

                            <div class="responsive-show" style="display: none;">
                                Last post by <a href="#" style="color: #AA0000;" class="username-coloured"></a> <?php echo $topic->created_by ?>&laquo; <a href="" title="Go to last post"><?php echo $topic->created_at ?></a>
                            </div>

                            <div class="responsive-hide">
                                by <a href="#" style="color: #AA0000;" class="username-coloured"><?php echo $topic->created_by ?></a> &raquo; <?php echo $topic->created_at ?>
                            </div>

                        </div>
                        </dt>
                        <dd class="posts"><?php echo $no_of_replies; ?> <dfn>Replies</dfn></dd>

                        <dd class="lastpost"><span><dfn>Last post </dfn>by <a href="#" style="color: #AA0000;" class="username-coloured"><?php echo $forum->forum_last_poster_name ?></a>
                                <a href="?action=viewtopic&forum_id=<?php echo $forum->id ?>&topic_id=<?php echo $topic->id ?>" title="Go to last post"><span class="imageset icon_topic_latest" title="View the latest post">View the latest post</span></a> <br /><?php echo $forum->forum_last_post_time ?></span>
                        </dd>
                    </dl>
                </li>
            </ul>
        <?php } ?>
    </div>
</div>