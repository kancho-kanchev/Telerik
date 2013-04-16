<?php
/**
 * The template for displaying the error 404 page.
 *
 *
 * @package CMS Systems
 * @subpackage Homework
 * @since CSS3 Color4 1.0
 */
?>
<?php get_header(); ?>
<!-- ******** error 404 ******** -->
<div id="site_content">
	<div id="sidebar_container">
		<?php get_sidebar('news'); ?>
		<?php get_sidebar('right-sidebar-links'); ?>
		<?php get_sidebar('tags'); ?>
	</div>
	<div class="content">
		<h1 class="center"><strong>404</strong></h1>
		<h2 class="center">Error Four Oh Four - Page Not Found</h2>
		<h4>Wooah you have tried to access a page which doesn't exist or has been moved. You have a few options:</h4>
		<h4>* Send me an e-mail and I will look into the error.</h4>
		<h4>* Go back to the homepage and take a look at my portfolio.</h4>
		<p></p>
		<h3>Press any link to continue...</h3>
		<h4><a href="<?php echo home_url(); ?>">Home</a>, <a href="http://kanchev-bg.com">Contact Me</a></h4>
	</div>
</div>
<?php get_footer(); ?>