<?php
/**
 * The template for displaying the sidebar with categories (or else).
 *
 *
 * @package CMS Systems
 * @subpackage Homework
 * @since CSS3 Color4 1.0
 */
?>
<!-- ******** sidebar links ******** -->
<?php if (! dynamic_sidebar('right-sidebar-links')):?>
	<div class="sidebar">
		<h3>Useful Links</h3>
		<ul>
			<li><a href="#">First Link</a></li>
			<li><a href="#">Another Link</a></li>
			<li><a href="#">And Another</a></li>
			<li><a href="#">Last One</a></li>
		</ul>
	</div>
<?php endif;?>