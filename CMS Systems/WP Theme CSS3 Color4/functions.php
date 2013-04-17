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

/**
 * Add Scripts.
 */
add_action('wp_enqueue_scripts', 'theme_enqueue_scripts');

function theme_enqueue_scripts () {
	wp_enqueue_script( 'modernizr-1.5',	get_template_directory_uri() . '/js/modernizr-1.5.min.js' );
	wp_enqueue_script( 'jQuery', get_template_directory_uri().'/js/jquery.js', array( 'jquery' ), '1.4.2', true );
	wp_enqueue_script( 'jquery.easing-sooper', get_template_directory_uri().'/js/jquery.easing-sooper.js', array( 'jquery' ), 0.1, true );
	wp_enqueue_script( 'jquery.sooperfish',	get_template_directory_uri() . '/js/jquery.sooperfish.js', array( 'jquery' ), 0.1, true );
	wp_enqueue_script( 'scripts',	get_template_directory_uri() . '/js/scripts.js', array( 'jquery' ), 0.1, true );
}

?>
