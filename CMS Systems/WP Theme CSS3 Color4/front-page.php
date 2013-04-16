<?php
/**
 * The template for displaying the front page.
 *
 *
 * @package CMS Systems
 * @subpackage Homework
 * @since CSS3 Color4 1.0
 */
?>
<?php get_header(); ?>
<!-- ******** front page ******** -->
<div id="site_content">
	<div id="sidebar_container">
		<?php get_sidebar('news'); ?>
		<?php get_sidebar('right-sidebar-links'); ?>
	</div>
	<div class="content">
	<h1>CMS System HomeWork</h1>
	<p>1. Install <strong>WAMP</strong> at home, set up Apache properly</p>
	<p>2. Create a <strong>'Hello PHP!'</strong> script and display it in your browser</p>
	<p>3. Create a <strong>PHP script</strong> that displays all numbers from 1 to 1000 that divide by 3 and 7</p>
	<p>4. Create a <strong>PHP form</strong> that accepts 3 fields - <strong>number</strong>, <strong>sign</strong> and another <strong>number</strong>.
		The form should submit to <strong>another PHP file</strong> which validates the input and calculates based
		on the numbers and the mathematical symbol. Use <strong>JavaScript for frontend validation</strong> of the form.
	</p>
	<p>5. Pick a template from <strong><a href="http://www.css3templates.co.uk/" target="_blank">http://www.css3templates.co.uk/</a></strong>
		and convert it to a simple WordPresstemplate. <strong>The theme should be:</strong></br>
		&nbsp;&nbsp;&nbsp;&nbsp;• Activated properly</br>
		&nbsp;&nbsp;&nbsp;&nbsp;• Working landing page with static content</br>
		&nbsp;&nbsp;&nbsp;&nbsp;• Working blog index with latest blogs
	</p>
	<p><a href="<?php echo home_url(); ?>/cms-sistemi-uprazhneniya">Translate and check solutions...</a></p>
<!--	<h1>Welcome to the CSS3_colour4 template</h1>
		<p>
			This simple, fixed width website template is released under a <a
				href="http://creativecommons.org/licenses/by/3.0">Creative Commons
				Attribution 3.0 Licence</a>. This means you are free to download and
			use it for personal and commercial projects. However, you <strong>must
				leave the 'design from css3templates.co.uk' link in the footer of
				the template</strong>.
		</p>
		<p>
			This template is written entirely in <strong>HTML5</strong> and <strong>CSS3</strong>.
		</p>
		<p>
			You can view more free CSS3 web templates <a
				href="http://www.css3templates.co.uk">here</a>.
		</p>
		<p>
			This template is a fully documented 5 page website, with an <a
				href="examples.html">examples</a> page that gives examples of all
			the styles available with this design. There is also a working PHP
			contact form on the contact page.
		</p>
-->
	</div>
</div>
<?php get_footer(); ?>