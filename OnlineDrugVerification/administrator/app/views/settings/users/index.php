<table id="datatable" class="table table-striped table-bordered">
    <thead>
        <tr>
            <th>S/N</th>
            <th>Username</th>
            <th>Password</th>
            <th>Permission</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>

        <?php
        $counter = 1;
        foreach ($users as $user) {
            ?>
            <tr>
                <td><?php echo $counter++; ?></td>
                <td><?php echo $user->username; ?></td>
                <td><?php echo $user->password; ?></td>
                <td><?php echo $user->permission; ?></td>
                <td>
                    <a class="btn btn-warning" href="?controller=settings&action=user_edit&id=<?php echo $user->id; ?>"><i class="fa fa-edit"></i>&nbsp;Edit</a>
                    <a class="btn btn-danger" href="?controller=settings&action=user_delete&id=<?php echo $user->id; ?>"><i class="fa fa-trash"></i>&nbsp;Delete</a>
                </td>
            </tr>                                
        <?php } ?>
    </tbody>
</table>
