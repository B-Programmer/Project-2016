<?php
/* Smarty version 3.1.30, created on 2016-10-02 13:28:27
  from "C:\VertrigoServ\www\ComputerScienceForum\administrator\app\views\post\index.tpl" */

/* @var Smarty_Internal_Template $_smarty_tpl */
if ($_smarty_tpl->_decodeProperties($_smarty_tpl, array (
  'version' => '3.1.30',
  'unifunc' => 'content_57f10b7b4598e1_52088501',
  'has_nocache_code' => false,
  'file_dependency' => 
  array (
    '67ffc1ce00b9903452eca3c839c59100327597cc' => 
    array (
      0 => 'C:\\VertrigoServ\\www\\ComputerScienceForum\\administrator\\app\\views\\post\\index.tpl',
      1 => 1475414904,
      2 => 'file',
    ),
  ),
  'includes' => 
  array (
  ),
),false)) {
function content_57f10b7b4598e1_52088501 (Smarty_Internal_Template $_smarty_tpl) {
?>
<div class="breadcrumbs ace-save-state" id="breadcrumbs">
    <ul class="breadcrumb">
        <li>
            <i class="ace-icon fa fa-home home-icon"></i>
            <a href="#">Home</a>
        </li>
        <li class="active">Posts</li>
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
                            <h3 class="header smaller lighter blue">Posts</h3>

                            <div class="clearfix">
                                <div class="pull-left"><a href="?controller=post&action=create" class="btn btn-primary" style="border: 2px"><strong class="fa fa-plus">&nbsp;Create New</strong></a></div>

                                <div class="pull-right tableTools-container"></div>
                            </div>
                            <div class="table-header">
                                Results for "Latest Registered Domains"
                            </div>

                            <!-- div.table-responsive -->

                            <!-- div.dataTables_borderWrap -->
                            <div>
                                <table id="dynamic-table" class="table table-striped table-bordered table-hover">
                                    <thead>
                                        <tr>
                                            <th class="center">
                                                <label class="pos-rel">
                                                    <input type="checkbox" class="ace" />
                                                    <span class="lbl"></span>
                                                </label>
                                            </th>
                                            <th>Post Content</th>
                                            <th>Topic ID</th>
                                            <th class="hidden-480"></th>

                                            <th>
                                                <i class="ace-icon fa fa-clock-o bigger-110 hidden-480"></i>
                                                Update
                                            </th>
                                            <th class="hidden-480">Status</th>

                                            <th></th>
                                        </tr>
                                    </thead>

                                    <tbody>
                                        <?php
$_from = $_smarty_tpl->smarty->ext->_foreach->init($_smarty_tpl, $_smarty_tpl->tpl_vars['posts']->value, 'forum');
if ($_from !== null) {
foreach ($_from as $_smarty_tpl->tpl_vars['forum']->value) {
?>
                                            <tr>
                                                <td class="center">
                                                    <label class="pos-rel">
                                                        <input type="checkbox" class="ace" />
                                                        <span class="lbl"></span>
                                                    </label>
                                                </td>

                                                <td>
                                                    <a href="#"><?php echo $_smarty_tpl->tpl_vars['forum']->value->content;?>
</a>
                                                </td>
                                                <td><?php echo $_smarty_tpl->tpl_vars['forum']->value->topic_id;?>
</td>
                                                <td class="hidden-480">3,330</td>
                                                <td>Feb 12</td>

                                                <td class="hidden-480">
                                                    <span class="label label-sm label-warning">Expiring</span>
                                                </td>

                                                <td>
                                                    <div class="hidden-sm hidden-xs action-buttons">
                                                        <a class="green" href="?controller=post&action=edit&id=<?php echo $_smarty_tpl->tpl_vars['forum']->value->id;?>
">
                                                            <i class="ace-icon fa fa-pencil bigger-130"></i>
                                                        </a>

                                                        <a class="red" href="?controller=post&action=delete&id=<?php echo $_smarty_tpl->tpl_vars['forum']->value->id;?>
">
                                                            <i class="ace-icon fa fa-trash-o bigger-130"></i>
                                                        </a>
                                                    </div>

                                                    <div class="hidden-md hidden-lg">
                                                        <div class="inline pos-rel">
                                                            <button class="btn btn-minier btn-yellow dropdown-toggle" data-toggle="dropdown" data-position="auto">
                                                                <i class="ace-icon fa fa-caret-down icon-only bigger-120"></i>
                                                            </button>

                                                            <ul class="dropdown-menu dropdown-only-icon dropdown-yellow dropdown-menu-right dropdown-caret dropdown-close">
                                                                <li>
                                                                    <a href="?controller=post&action=edit&id=<?php echo $_smarty_tpl->tpl_vars['forum']->value->id;?>
" class="tooltip-success" data-rel="tooltip" title="Edit">
                                                                        <span class="green">
                                                                            <i class="ace-icon fa fa-pencil-square-o bigger-120"></i>
                                                                        </span>
                                                                    </a>
                                                                </li>

                                                                <li>
                                                                    <a href="?controller=post&action=delete&id=<?php echo $_smarty_tpl->tpl_vars['forum']->value->id;?>
" class="tooltip-error" data-rel="tooltip" title="Delete">
                                                                        <span class="red">
                                                                            <i class="ace-icon fa fa-trash-o bigger-120"></i>
                                                                        </span>
                                                                    </a>
                                                                </li>
                                                            </ul>
                                                        </div>
                                                    </div>
                                                </td>
                                            </tr>
                                        <?php
}
}
$_smarty_tpl->smarty->ext->_foreach->restore($_smarty_tpl);
?>

                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div><!-- /.span -->
                <!-- PAGE CONTENT ENDS -->
            </div><!-- /.col -->
        </div><!-- /.row -->
    </div><!-- /.page-content --><?php }
}
