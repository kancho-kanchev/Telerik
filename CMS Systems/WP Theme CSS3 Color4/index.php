<?php
/**
 * The template for displaying the most pages.
 *
 *
 * @package CMS Systems
 * @subpackage Homework
 * @since CSS3 Color4 1.0
 */
?>
<?php get_header(); ?>
<!-- ******** content ******** -->
<div id="site_content">
	<div id="sidebar_container">
		<?php get_sidebar('news'); ?>
		<?php get_sidebar('right-sidebar-links'); ?>
		<?php get_sidebar('tags'); ?>
	</div>
	<div class="content">
		<?php if (have_posts()) : ?>
			<?php while (have_posts()) : the_post(); ?>
				<div class="post" id="post-<?php the_ID(); ?>">
					<h2>
						<a href="<?php the_permalink() ?>" rel="bookmark" title="Връзка към <?php the_title_attribute(); ?>"><?php the_title(); ?></a>
					</h2>
					<div class="categorylink">
						<h5>Категория: <?php the_category(', ') ?></h5>
					</div>
					<div class="entry">
						<?php //the_excerpt('Read the rest of this entry &raquo;'); ?>
						<?php the_content('<p class="serif">Read the rest of this page &raquo;</p>'); ?>
						<?php wp_link_pages(array('before' => '<p><strong>Pages:</strong> ', 'after' => '</p>', 'next_or_number' => 'number')); ?>
						<?php the_tags( '<p>Етикети: ', ', ', '</p>'); ?>
					</div>
					<div class="postmetadata">
						<div class="category">
							<h5><?php the_time('F jS, Y') ?><!-- by <?php the_author() ?> --></h5>
						</div>
						<div class="comments">
							<?php //comments_popup_link('Все още няма коментари', '1 коментар досега', '% коментара досега', 'comments-link', 'Comments off'); ?>
							<hr>
						</div>
					</div>
				</div>
			<?php endwhile; ?>
			<div class="navigation">
				<div class="alignleft">
					<?php next_posts_link('&laquo; Older Entries') ?>
				</div>
				<div class="alignright">
					<?php previous_posts_link('Newer Entries &raquo;') ?>
				</div>
			</div>
		<?php else : ?>
			<h2 class="center">Not Found</h2>
			<p class="center">Sorry, but you are looking for something that isn't here.</p>
			<?php //include (TEMPLATEPATH . "/searchform.php"); ?>
		<?php endif; ?>
	</div>
</div>
<?php get_footer(); ?>