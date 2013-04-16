<?php 
/**
 * Functions and definitions.
 *
 *
 * @package CMS systems
 * @subpackage Homework
 * @since CSS3 Color4 1.0
 */
/**
 * Sets up the sidebars.
 */
$sidebar_args = array(
		'id' => 'sidebar-news',
		'name' => 'Main Sidebar News',
		'description'   => '',
		'class'         => '',
		'before_widget' => '<div class="sidebar">',
		'after_widget'  => '</div>',
		'before_title'  => '<h3>',
		'after_title'   => '</h3>'
		);
register_sidebar($sidebar_args);

$sidebar_args = array(
		'id' => 'right-sidebar-links',
		'name' => 'Main Sidebar Links',
		'description'   => '',
		'class'         => '',
		'before_widget' => '<div class="sidebar">',
		'after_widget'  => '</div>',
		'before_title'  => '<h3>',
		'after_title'   => '</h3>'
);
register_sidebar($sidebar_args);

$sidebar_args = array(
		'id' => 'right-sidebar-tags',
		'name' => 'Main Sidebar Tags',
		'description'   => '',
		'class'         => '',
		'before_widget' => '<div class="sidebar">',
		'after_widget'  => '</div>',
		'before_title'  => '<h3>',
		'after_title'   => '</h3>'
);
register_sidebar($sidebar_args);

/**
 * Sets up the menu.
 */
register_nav_menu('top-side-menu', "My top side menu");

?>
