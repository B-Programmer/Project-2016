<!-- page content -->
<div class="right_col" role="main">
    <div class="">
        <div class="page-title">

            <div class="title_left">
                <h3>
                    Drugs
                    <small>
                        create, edit and delete drugs
                    </small>
                </h3>
            </div>

            <div class="title_right">
                <div class="col-md-5 col-sm-5 col-xs-12 form-group pull-right top_search">
                    <a class="btn btn-info btn-block" href="?controller=drug&action=create"><i class="fa fa-file-text"></i>&nbsp;Register New Drug</a>
                </div>
            </div>
        </div>
        <div class="clearfix"></div>

        <div class="row">

            <div class="col-md-12 col-sm-12 col-xs-12">
                <div class="x_panel">
                    <div class="x_title">
                        <h2>List Of Registered Drugs</h2>
                        <div class="clearfix"></div>
                    </div>
                    <div class="x_content">
                        <p class="text-muted font-13 m-b-30">
                            Below are the list of registered drugs.
                        </p>
                        <table id="datatable" class="table table-striped table-bordered">
                            <thead>
                                <tr>
                                    <th>S/N</th>
                                    <th>Title</th>
                                    <th>Production Date</th>
                                    <th>Expiry Date</th>
                                    <th>PIN</th>
                                    <th>Actions</th>
                                </tr>
                            </thead>


                            <tbody>
                                <?php
                                $counter = 1;
                                foreach ($drug as $drug) {
                                    ?>
                                    <tr>
                                        <td><?php echo $counter++; ?></td>
                                        <td><?php echo $drug->title; ?></td>
                                        <td><?php echo $drug->production_date; ?></td>
                                        <td><?php echo $drug->expiry_date; ?></td>
                                        <td><?php echo $drug->pin; ?></td>
                                        <td>
                                            <a class="btn btn-warning" href="?controller=drug&action=edit&id=<?php echo $drug->id; ?>"><i class="fa fa-edit"></i>&nbsp;Edit</a>
                                            <a class="btn btn-danger" href="?controller=drug&action=delete&id=<?php echo $drug->id; ?>"><i class="fa fa-trash"></i>&nbsp;Delete</a>
                                        </td>
                                    </tr>                                
                                <?php } ?>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- /page content -->