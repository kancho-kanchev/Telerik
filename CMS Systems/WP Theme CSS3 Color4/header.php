<?php
/**
 * The template for displaying the header.
 *
 *
 * @package CMS Systems
 * @subpackage Homework
 * @since CSS3 Color4 1.0
 */
?>
<!DOCTYPE HTML>
<html>
<head>
	<title><?php bloginfo('name'); ?></title>
	<meta name="description" content="<?php bloginfo( 'description' ); ?>" />
	<meta name="keywords" content="website keywords, website keywords" />
	<meta http-equiv="content-type" content="text/html; charset=UTF-8" />
	<link rel="stylesheet" type="text/css" href="<?php bloginfo("stylesheet_url"); ?>" />
	<!-- modernizr enables HTML5 elements and feature detects -->
	<script type="text/javascript" src="<?php echo get_template_directory_uri() ?>/js/modernizr-1.5.min.js"></script>
	<?php wp_head(); ?>
</head>
<body <?php body_class(); ?>>
<div id="main">
	<header>
		<div id="logo">
			<div id="logo_text">
				<!-- class="logo_colour", allows you to change the colour of the text -->
				<h1>
					<a href="<?php echo home_url(); ?>"><?php bloginfo('name'); ?><span class="logo_colour"> CSS3_colour4 Theme</span></a>
				</h1>
				<h2><?php bloginfo('description')?></h2>
			</div>
		</div>
		<nav>
			<?php wp_nav_menu(array (
			'theme_location' => 'top-side-menu',
			'container'		 => 'div',
			'container_id'	 => 'menu_container',
			'menu_class'     => 'sf-menu',
			'menu_id'        => 'nav'
			)
		);?>
		</nav>
	</header>