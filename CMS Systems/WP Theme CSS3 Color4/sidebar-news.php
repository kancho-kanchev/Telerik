<?php
/**
 * The template for displaying the sidebar with latest news (or else).
 *
 *
 * @package CMS Systems
 * @subpackage Homework
 * @since CSS3 Color4 1.0
 */
?>
<!-- ******** sidebar news ******** -->
<?php if (! dynamic_sidebar('right-sidebar-news')):?>
<div class="sidebar">
	<?php
	global $more;
	$more = 0;
	query_posts('cat=6');
	if(have_posts()) :
		the_post(); ?>
		<h3>Последни новини</h3>
		<h4><a href="<?php the_permalink(); ?>"><?php the_title();?></a></h4>
		<h5><?php the_time('F jS, Y') ?></h5>
		<?php the_content('Read More');
	else : ?>
		<h3>Latest News</h3>
		<h4>New Website Launched</h4>
		<h5>January 1st, 2012</h5>
		<p>
			2012 sees the redesign of our website. Take a look around and let us
			know what you think.<br /> <a href="#">Read more</a>
		</p>
	<?php endif;
	wp_reset_query(); ?>
</div>
<?php endif;?>