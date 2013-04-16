<?php
/**
 * The template for displaying the footer.
 *
 *
 * @package CMS systems
 * @subpackage Homework
 * @since CSS3 Color4 1.0
 */
?>
	<footer>
		<p>
			Copyright &copy; <a	href="http://kanchev-bg.com" target="_blank">Kancho Kanchev</a> | 
			<a href="http://www.css3templates.co.uk" target="_blank">design from css3templates.co.uk</a>
		</p>
	</footer>
</div>
<p>&nbsp;</p>
<!-- javascript at the bottom for fast page loading -->
<script type="text/javascript" src="<?php echo get_template_directory_uri() ?>/js/jquery.js"></script>
<script type="text/javascript" src="<?php echo get_template_directory_uri() ?>/js/jquery.easing-sooper.js"></script>
<script type="text/javascript" src="<?php echo get_template_directory_uri() ?>/js/jquery.sooperfish.js"></script>
<script type="text/javascript">
$(document).ready(function() {
	$('ul.sf-menu').sooperfish();
});
</script>
<?php wp_footer(); ?>
</body>
</html>
