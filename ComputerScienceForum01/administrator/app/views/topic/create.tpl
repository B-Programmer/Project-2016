<div class="breadcrumbs ace-save-state" id="breadcrumbs">
    <ul class="breadcrumb">
        <li>
            <i class="ace-icon fa fa-home home-icon"></i>
            <a href="#">Home</a>
        </li>

        <li>
            <a href="?controller=topic&action=index">Topics</a>
        </li>
        <li class="active">Create Topic</li>
    </ul><!-- /.breadcrumb -->

    <div class="nav-search" id="nav-search">
        <form class="form-search">
            <span class="input-icon">
                <input type="text" placeholder="Search ..." class="nav-search-input" id="nav-search-input" autocomplete="off" />
                <i class="ace-icon fa fa-search nav-search-icon"></i>
            </span>
        </form>
    </div><!-- /.nav-search -->
</div>

<div class="page-content">

    <div class="row">
        <div class="col-xs-12">
            <!-- PAGE CONTENT BEGINS -->
            <div class="row">
                <div class="col-xs-12">
                    <div class="row">
                        <div class="col-xs-12">
                            <h3 class="header smaller lighter blue">Create New Topic</h3>

                            <div class="clearfix">
                                <div class="pull-left">
                                    <a href="?controller=topic&action=index" class="btn btn-danger" style="border: 2px">
                                        <strong class="fa fa-arrow-left">&nbsp;Return</strong>
                                    </a>
                                </div>
                            </div>

                            <!-- div.table-responsive -->
                            <form class="form-horizontal" role="form" action="?controller=topic&action=store" method="POST">
                                <div class="form-group">
                                    <label class="col-sm-3 control-label no-padding-right" for="form-field-1"> Select Forum </label>

                                    <div class="col-sm-9">
                                        <select name="forum_id" class="col-xs-10 col-sm-5">
                                            {foreach $forums as $forum}
                                                <option value="{$forum->id}">{$forum->forum_name}</option>
                                            {/foreach}
                                        </select>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label no-padding-right" for="form-field-1"> Topic Subject </label>

                                    <div class="col-sm-9">
                                        <input name="subject" type="text" id="form-field-1" placeholder="Topic Subject" class="col-xs-10 col-sm-5" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label no-padding-right" for="form-field-1"> Topic Content</label>

                                    <div class="col-sm-9">
                                        <textarea name="content" class="col-xs-10 col-sm-5" id="form-field-1" placeholder="Topic Content"></textarea>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label no-padding-right" for="form-field-1"></label>

                                    <div class="col-sm-9">
                                        <button class="btn btn-white btn-info btn-bold col-xs-10 col-sm-5">
                                            <i class="ace-icon fa fa-floppy-o bigger-120 blue"></i>
                                            Create
                                        </button>
                                    </div>
                                </div>

                            </form>
                            <!-- div.dataTables_borderWrap -->

                        </div>
                    </div>
                </div><!-- /.span -->
                <!-- PAGE CONTENT ENDS -->
            </div><!-- /.col -->
        </div><!-- /.row -->
    </div><!-- /.page-content -->