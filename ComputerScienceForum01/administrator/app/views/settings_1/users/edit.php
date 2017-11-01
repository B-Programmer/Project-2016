<p class="text-center">Edit existing user.</p>

<form id="demo-form2" method="post" action="?controller=settings&action=user_update&id=<?php echo $_GET['id']; ?>" data-parsley-validate class="form-horizontal form-label-left">

    <div class="form-group">
        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="subject-name">Username<span class="required"> &ast; </span>
        </label>
        <div class="col-md-6 col-sm-6 col-xs-12">
            <input type="text" name="username" id="subject-name" required="required" value="<?php echo $auser->username ?>" class="form-control col-md-7 col-xs-12">
        </div>
    </div>
    <div class="form-group">
        <label class="control-label col-md-3 col-sm-3 col-xs-12" for="quesions">Password <span class="required"> &ast;</span>
        </label>
        <div class="col-md-6 col-sm-6 col-xs-12">
            <input type="password" id="questions" name="password" required="required" class="form-control">
        </div>
    </div>

    <div class="ln_solid"></div>
    <div class="form-group">
        <div class="col-md-6 col-sm-6 col-xs-12 col-md-offset-3">
            <a href="?controller=settings&action=index" class="btn btn-primary">Cancel</a> 
            <button type="submit" class="btn btn-success">Update User</button>
        </div>
    </div>
</form>