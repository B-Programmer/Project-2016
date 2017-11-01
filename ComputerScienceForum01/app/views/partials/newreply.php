
<form id="postform" method="post" action="?action=save_new_reply&forum_id=<?php echo $_GET['forum_id'] ?>&topic_id=<?php echo $_GET['topic_id'] ?>" enctype="multipart/form-data">


    <div class="panel" id="postingbox">
        <div class="inner">

            <h3>Post a reply</h3>

            <fieldset class="fields1">

                <dl style="clear: left;">
                    <dt><label for="subject">Subject:</label></dt>
                    <dd><input type="text" name="subject" id="subject" size="45" maxlength="124" tabindex="2" value="Re: <?php echo $topic->subject ?>" class="inputbox autowidth" /></dd>
                </dl>

                <script type="text/javascript">
                    // <![CDATA[
                    var form_name = 'postform';
                    var text_name = 'message';
                    var load_draft = false;
                    var upload = false;

                    // Define the bbCode tags
                    var bbcode = new Array();
                    var bbtags = new Array('[b]', '[/b]', '[i]', '[/i]', '[u]', '[/u]', '[quote]', '[/quote]', '[code]', '[/code]', '[list]', '[/list]', '[list=]', '[/list]', '[img]', '[/img]', '[url]', '[/url]', '[flash=]', '[/flash]', '[size=]', '[/size]');
                    var imageTag = false;

                    // Helpline messages
                    var help_line = {
                        b: 'Bold text: [b]text[/b]',
                        i: 'Italic text: [i]text[/i]',
                        u: 'Underline text: [u]text[/u]',
                        q: 'Quote text: [quote]text[/quote]',
                        c: 'Code display: [code]code[/code]',
                        l: 'List: [list][*]text[/list]',
                        o: 'Ordered list: e.g. [list=1][*]First point[/list] or [list=a][*]Point a[/list]',
                        p: 'Insert image: [img]http://image_url[/img]',
                        w: 'Insert URL: [url]http://url[/url] or [url=http://url]URL text[/url]',
                        a: 'Inline uploaded attachment: [attachment=]filename.ext[/attachment]',
                        s: 'Font colour: [color=red]text[/color] or [color=#FF0000]text[/color]',
                        f: 'Font size: [size=85]small text[/size]',
                        y: 'List: Add list element',
                        d: 'Flash: [flash=width,height]http://url[/flash]'
                    }

                    function change_palette()
                    {
                        phpbb.toggleDisplay('colour_palette');
                        e = document.getElementById('colour_palette');

                        if (e.style.display == 'block')
                        {
                            document.getElementById('bbpalette').value = 'Hide font colour';
                        }
                        else
                        {
                            document.getElementById('bbpalette').value = 'Font colour';
                        }
                    }

                    // ]]>
                </script>

                <div id="colour_palette" style="display: none;">
                    <dl style="clear: left;">
                        <dt><label>Font colour:</label></dt>
                        <dd id="color_palette_placeholder" data-orientation="h" data-height="12" data-width="15" data-bbcode="true"></dd>
                    </dl>
                </div>

                <div id="format-buttons">
                    <input type="button" class="button2 bbcode-b" accesskey="b" name="addbbcode0" value=" B " style="font-weight:bold; width: 30px" onclick="bbstyle(0)" title="Bold text: [b]text[/b]" />
                    <input type="button" class="button2 bbcode-i" accesskey="i" name="addbbcode2" value=" i " style="font-style:italic; width: 30px" onclick="bbstyle(2)" title="Italic text: [i]text[/i]" />
                    <input type="button" class="button2 bbcode-u" accesskey="u" name="addbbcode4" value=" u " style="text-decoration: underline; width: 30px" onclick="bbstyle(4)" title="Underline text: [u]text[/u]" />
                    <input type="button" class="button2 bbcode-quote" accesskey="q" name="addbbcode6" value="Quote" style="width: 50px" onclick="bbstyle(6)" title="Quote text: [quote]text[/quote]" />
                    <input type="button" class="button2 bbcode-code" accesskey="c" name="addbbcode8" value="Code" style="width: 40px" onclick="bbstyle(8)" title="Code display: [code]code[/code]" />
                    <input type="button" class="button2 bbcode-list" accesskey="l" name="addbbcode10" value="List" style="width: 40px" onclick="bbstyle(10)" title="List: [list][*]text[/list]" />
                    <input type="button" class="button2 bbcode-list-" accesskey="o" name="addbbcode12" value="List=" style="width: 40px" onclick="bbstyle(12)" title="Ordered list: e.g. [list=1][*]First point[/list] or [list=a][*]Point a[/list]" />
                    <input type="button" class="button2 bbcode-asterisk" accesskey="y" name="addlistitem" value="[*]" style="width: 40px" onclick="bbstyle(-1)" title="List item: [*]text" />
                    <input type="button" class="button2 bbcode-img" accesskey="p" name="addbbcode14" value="Img" style="width: 40px" onclick="bbstyle(14)" title="Insert image: [img]http://image_url[/img]" />
                    <input type="button" class="button2 bbcode-url" accesskey="w" name="addbbcode16" value="URL" style="text-decoration: underline; width: 40px" onclick="bbstyle(16)" title="Insert URL: [url]http://url[/url] or [url=http://url]URL text[/url]" />
                    <input type="button" class="button2 bbcode-flash" accesskey="d" name="addbbcode18" value="Flash" onclick="bbstyle(18)" title="Flash: [flash=width,height]http://url[/flash]" />
                    <select name="addbbcode20" class="bbcode-size" onchange="bbfontstyle('[size=' + this.form.addbbcode20.options[this.form.addbbcode20.selectedIndex].value + ']', '[/size]');
                            this.form.addbbcode20.selectedIndex = 2;" title="Font size: [size=85]small text[/size]">
                        <option value="50">Tiny</option>
                        <option value="85">Small</option>
                        <option value="100" selected="selected">Normal</option>
                        <option value="150">Large</option>
                        <option value="200">Huge</option>
                    </select>
                    <input type="button" class="button2 bbcode-color" name="bbpalette" id="bbpalette" value="Font colour" onclick="change_palette();" title="Font colour: [color=red]text[/color] or [color=#FF0000]text[/color]" />


                </div>

                <div id="smiley-box">

                    <strong>Smilies</strong><br />
                    <a href="#" onclick="insert_text(':D', true);
                            return false;"><img src="public/assets/images/icon_e_biggrin.gif" width="15" height="17" alt=":D" title="Very Happy" /></a>
                    <a href="#" onclick="insert_text(':)', true);
                            return false;"><img src="public/assets/images/icon_e_smile.gif" width="15" height="17" alt=":)" title="Smile" /></a>
                    <a href="#" onclick="insert_text(';)', true);
                            return false;"><img src="public/assets/images/icon_e_wink.gif" width="15" height="17" alt=";)" title="Wink" /></a>
                    <a href="#" onclick="insert_text(':(', true);
                            return false;"><img src="public/assets/images/icon_e_sad.gif" width="15" height="17" alt=":(" title="Sad" /></a>
                    <a href="#" onclick="insert_text(':o', true);
                            return false;"><img src="public/assets/images/icon_e_surprised.gif" width="15" height="17" alt=":o" title="Surprised" /></a>
                    <a href="#" onclick="insert_text(':shock:', true);
                            return false;"><img src="public/assets/images/icon_eek.gif" width="15" height="17" alt=":shock:" title="Shocked" /></a>
                    <a href="#" onclick="insert_text(':?', true);
                            return false;"><img src="public/assets/images/icon_e_confused.gif" width="15" height="17" alt=":?" title="Confused" /></a>
                    <a href="#" onclick="insert_text('8-)', true);
                            return false;"><img src="public/assets/images/icon_cool.gif" width="15" height="17" alt="8-)" title="Cool" /></a>
                    <a href="#" onclick="insert_text(':lol:', true);
                            return false;"><img src="public/assets/images/icon_lol.gif" width="15" height="17" alt=":lol:" title="Laughing" /></a>
                    <a href="#" onclick="insert_text(':x', true);
                            return false;"><img src="public/assets/images/icon_mad.gif" width="15" height="17" alt=":x" title="Mad" /></a>
                    <a href="#" onclick="insert_text(':P', true);
                            return false;"><img src="public/assets/images/icon_razz.gif" width="15" height="17" alt=":P" title="Razz" /></a>
                    <a href="#" onclick="insert_text(':oops:', true);
                            return false;"><img src="public/assets/images/icon_redface.gif" width="15" height="17" alt=":oops:" title="Embarrassed" /></a>
                    <a href="#" onclick="insert_text(':cry:', true);
                            return false;"><img src="public/assets/images/icon_cry.gif" width="15" height="17" alt=":cry:" title="Crying or Very Sad" /></a>
                    <a href="#" onclick="insert_text(':evil:', true);
                            return false;"><img src="public/assets/images/icon_evil.gif" width="15" height="17" alt=":evil:" title="Evil or Very Mad" /></a>
                    <a href="#" onclick="insert_text(':twisted:', true);
                            return false;"><img src="public/assets/images/icon_twisted.gif" width="15" height="17" alt=":twisted:" title="Twisted Evil" /></a>
                    <a href="#" onclick="insert_text(':roll:', true);
                            return false;"><img src="public/assets/images/icon_rolleyes.gif" width="15" height="17" alt=":roll:" title="Rolling Eyes" /></a>
                    <a href="#" onclick="insert_text(':!:', true);
                            return false;"><img src="public/assets/images/icon_exclaim.gif" width="15" height="17" alt=":!:" title="Exclamation" /></a>
                    <a href="#" onclick="insert_text(':?:', true);
                            return false;"><img src="public/assets/images/icon_question.gif" width="15" height="17" alt=":?:" title="Question" /></a>
                    <a href="#" onclick="insert_text(':idea:', true);
                            return false;"><img src="public/assets/images/icon_idea.gif" width="15" height="17" alt=":idea:" title="Idea" /></a>
                    <a href="#" onclick="insert_text(':arrow:', true);
                            return false;"><img src="public/assets/images/icon_arrow.gif" width="15" height="17" alt=":arrow:" title="Arrow" /></a>
                    <a href="#" onclick="insert_text(':|', true);
                            return false;"><img src="public/assets/images/icon_neutral.gif" width="15" height="17" alt=":|" title="Neutral" /></a>
                    <a href="#" onclick="insert_text(':mrgreen:', true);
                            return false;"><img src="public/assets/images/icon_mrgreen.gif" width="15" height="17" alt=":mrgreen:" title="Mr. Green" /></a>
                    <a href="#" onclick="insert_text(':geek:', true);
                            return false;"><img src="public/assets/images/icon_e_geek.gif" width="17" height="17" alt=":geek:" title="Geek" /></a>
                    <a href="#" onclick="insert_text(':ugeek:', true);
                            return false;"><img src="public/assets/images/icon_e_ugeek.gif" width="17" height="18" alt=":ugeek:" title="Uber Geek" /></a>
                    <div class="bbcode-status">
                        <hr />			<a href="./faq.php?mode=bbcode">BBCode</a> is <em>ON</em><br />
                        [img] is <em>ON</em><br />
                        [flash] is <em>ON</em><br />
                        [url] is <em>ON</em><br />
                        Smilies are <em>ON</em>
                    </div>
                    <hr />						<strong><a href="#review">Topic review</a></strong>			</div>


                <div id="message-box">
                    <textarea name="message" id="message" rows="15" cols="76" tabindex="4" onselect="storeCaret(this);" onclick="storeCaret(this);" onkeyup="storeCaret(this);" onfocus="initInsertions();" class="inputbox"></textarea>
                </div>

            </fieldset>


        </div>
    </div>

    <div class="panel bg2">
        <div class="inner">

            <fieldset class="submit-buttons">
                <input type="submit" accesskey="s" tabindex="6" name="post" value="Submit" class="button1 default-submit-action" />
            </fieldset>

        </div>
    </div>


    <h3 id="review">
        <span class="right-box"><a href="#review" onclick="viewableArea(getElementById('topicreview'), true);
                var rev_text = getElementById('review').getElementsByTagName('a').item(0).firstChild;
                if (rev_text.data == 'Expand view') {
                    rev_text.data = 'Collapse view';
                } else if (rev_text.data == 'Collapse view') {
                    rev_text.data = 'Expand view'
                }
                ;">Expand view</a>
        </span>
        Topic review: <?php echo $topic->subject ?>
    </h3>
    <div id="topicreview">
        <script type="text/javascript">
            // <![CDATA[
            bbcodeEnabled = 1;
            // ]]>
        </script>
        <?php require_once 'listposts.php'; ?>
    </div>

    <hr />

    <p><a href="#postingbox" class="top2">Top</a></p>

</form>