<?php $__env->startSection('welcome'); ?>
<div class="relative justify-center items-center">
    <div class="top-0">
        <div class="absolute justify-content-center align-items-center font-bold text-info p-6" style="font-size: 2rem">
          Sicily Lines
        </div>
        <div class="p-6 text-right z-10">
            <?php if(Route::has('login')): ?>
                    <?php if(auth()->guard()->check()): ?>
                        <a href="<?php echo e(url('/dashboard')); ?>" class="font-semibold text-blue-400 hover:text-blue-400 dark:text-gray-400 dark:hover:text-white focus:outline focus:outline-2 focus:outline-red-500">Dashboard</a>
                    <?php else: ?>
                        <a href="<?php echo e(route('login')); ?>" class="font-semibold text-gray-600 hover:text-gray-900 dark:text-gray-400 dark:hover:text-white focus:outline focus:outline-2 focus:outline-red-500">Log in</a>
                    <?php endif; ?>
                
            <?php endif; ?>
        </div>
    </div>
</div>

<?php $__env->stopSection(); ?>
<?php echo $__env->make('template', \Illuminate\Support\Arr::except(get_defined_vars(), ['__data', '__path']))->render(); ?><?php /**PATH C:\laragon\www\SicilyLines\resources\views/welcome.blade.php ENDPATH**/ ?>