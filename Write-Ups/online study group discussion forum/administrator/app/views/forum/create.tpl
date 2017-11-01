<div class="breadcrumbs ace-save-state" id="breadcrumbs">
    <ul class="breadcrumb">
        <li>
            <i class="ace-icon fa fa-home home-icon"></i>
            <a href="#">Home</a>
        </li>

        <li>
            <a href="?controller=forum&action=index">Forums</a>
        </li>
        <li class="active">Create Forum</li>
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
                            <h3 class="header smaller lighter blue">Create New Forum</h3>

                            <div class="clearfix">
                                <div class="pull-left"><a href="?controller=forum&action=index" class="btn btn-danger" style="border: 2px"><strong class="fa fa-arrow-left">&nbsp;Return</strong></a></div>
                            </div>

                            <!-- div.table-responsive -->
                            <form class="form-horizontal" role="form" action="?controller=forum&action=store" method="POST">
                                <div class="form-group">
                                    <label class="col-sm-3 control-label no-padding-right" for="form-field-1"> Forum Name </label>

                                    <div class="col-sm-9">
                                        <input name="forum_name" type="text" id="form-field-1" placeholder="Forum Name" class="col-xs-10 col-sm-5" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-3 control-label no-padding-right" for="form-field-1"> Forum Description</label>

                                    <div class="col-sm-9">
                                        <textarea name="forum_desc" class="col-xs-10 col-sm-5" id="form-field-1" placeholder="Forum Description"></textarea>
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