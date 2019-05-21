-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: May 21, 2019 at 09:35 PM
-- Server version: 5.7.25
-- PHP Version: 7.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pupster`
--
CREATE DATABASE IF NOT EXISTS `pupster` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `pupster`;

-- --------------------------------------------------------

--
-- Table structure for table `dogs`
--

CREATE TABLE `dogs` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `photo` text NOT NULL,
  `sex` varchar(255) NOT NULL,
  `breed` varchar(255) NOT NULL,
  `color` varchar(255) NOT NULL,
  `size` varchar(255) NOT NULL,
  `age` varchar(255) NOT NULL,
  `neutered_spayed` tinyint(1) NOT NULL,
  `shots_up_to_date` tinyint(1) NOT NULL,
  `activity_level` varchar(255) NOT NULL,
  `good_with_dogs` tinyint(1) NOT NULL,
  `good_with_cats` tinyint(1) NOT NULL,
  `good_with_kids` tinyint(1) NOT NULL,
  `house_trained` tinyint(1) NOT NULL,
  `good_alone` tinyint(1) NOT NULL,
  `needs_description` mediumtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `dogs`
--

INSERT INTO `dogs` (`id`, `name`, `photo`, `sex`, `breed`, `color`, `size`, `age`, `neutered_spayed`, `shots_up_to_date`, `activity_level`, `good_with_dogs`, `good_with_cats`, `good_with_kids`, `house_trained`, `good_alone`, `needs_description`) VALUES
(1, 'Avery', 'img/Avery.jpg', 'Male', '\r\nAmerican Staffordshire Terrier/Boxer Mix', '\r\nBlack - with White', 'Large 61-100 lbs (28-45 kg)', '\r\n9 years old, Adult', 1, 1, 'medium', 1, 0, 0, 1, 1, 'Meet Avery! This handsome guy is as sweet as they come! Don\'t let Avery\'s age fool you, this young senior still has a lot of pep in his step and lots of years left to enjoy with a family of his own. Avery loves his daily walks and could still easily handle some light hiking even! One of the perks of adopting a mature dog is that they know when it\'s time to chill and are happy to do so! Avery enjoys doggie friends that are similar in size and still very much likes to play. He\'s loves everyone he meets and we know he will make a really awesome addition to a loving family! Open your home to this incredibly sweet dog and we promise you won\'t regret it! \r\nEmail or visit our website to submit your application!'),
(3, 'Blanche', 'img/Blanche.jpg', 'Female', 'Chihuahua Mix', 'Black - with Tan, Yellow or Fawn', 'Small 25 lbs (11 kg) or less', '10 years old, Senior', 1, 1, 'low; likes to cuddle and hang out the most', 1, 1, 1, 1, 1, 'Meet are teeny-tiny senior gal Blanche! This adorable 5 lb nugget may be small, but shes got big personality! Blanche is the perfect combo of sass and sweetness! She likes to take a minute to get comfortable with new people, but once she does she\'ll be in your lap, on her back, rolling around like the goofy girl she is! She currently lives with another senior male Chihuahua, a female Poodle and a cat. While she can be sassy to her k9 friends, she does just fine living with them and we think deep down she enjoys the company. ;) Blanche would love to find a family of her own to enjoy her golden years with, this girls still got a whole lotta love to share! \r\nEmail or visit our website to submit your application!'),
(5, 'Cleo', 'img/Cleo.jpg', 'Female', 'American Staffordshire Terrier Mix', 'Black - with White', 'Med. 26-60 lbs (12-27 kg)', '5 years old, Adult', 1, 1, 'high', 1, 0, 1, 1, 1, 'Meet Cleo! Cleo had spent the first 6 years of her life in a home before her human passed away so when this girl entered the shelter her world had really been turned upside down. \r\nCleo would love to find a home with a mellow male dog, large or small. Older kids (she can become overly excited with younger kiddos) and no cats. Cleo would thrive in the care of confident humans that can provide her with the structure she enjoys and that helps her feel secure. This sweet girl is very smart, eager to please and is the perfect balance of adventure dog/snuggle bud. At just about 40 lbs this “pocket pittie” makes a perfect lap dog, she’s incredibly affectionate. Cleo has been working with a trainer, learning lots and adjusting well. She’s brushed up on her manners and is officially ready to join a new forever family! '),
(7, 'Dorothy ', 'img/Dorothy.jpg', 'Female', 'Shepherd (Unknown Type)/Chow Chow Mix', 'Black', 'Med. 26-60 lbs (12-27 kg)', '11 years old, Senior', 1, 1, 'less active ', 1, 0, 1, 1, 1, 'Dorothy is apart of our “Golden Girls” duo with her best friend Rose. \r\nDorothy is always ready to soak up all the cuddles and massages. She has slowed down a bit in her old age, but what she lacks in speed, she makes up for in personality and charm. She enjoys short leisurely strolls around the rescue with lots of pit stops for grass-nibbling and taking in the scenery. She’s very patient when it’s time for nail trims, ear cleanings or bath time. An ideal day for Dorothy would include spending quality time with a human companion and her bff Rose on a big comfy couch with maybe a few treats here and there. She can be wary of strangers at first, but it doesn’t take long for her to warm up and happily accept snuggles from anyone! \r\nThis duo would love to find a quiet forever home and loving family to enjoy their golden years with and trust us, opening your heart and home to a senior dog(s) is one the most rewarding things you can do. Watching them thrive and enjoy life as every senior dog should get to do is SO special. '),
(9, 'Pinky', 'img/Pinky.jpg', 'Female', 'Chihuahua/Dachshund Mix', 'Tan/Yellow/Fawn - with White', '\r\n(when grown) Small 25 lbs (11 kg) or less', '2 months old, Puppy', 0, 1, 'high', 1, 1, 1, 0, 0, 'Just a pup, Pinky needs lots of love and attention. She needs to be house trained. Look how cute! Come fall in love with this sweet little button. '),
(11, 'Rosie', 'img/Rosie.jpg', 'Female', 'American Pit Bull Terrier Mix', 'Red/Golden/Orange/Chestnut - with White', 'Med. 26-60 lbs (12-27 kg)', 'senior', 1, 1, 'low', 1, 0, 1, 1, 1, 'The other half of the “Golden Girls” duo, Rose has the most heart warming friendship with her partner in crime Dorothy. Though this gal is a senior, her mobility is still quite good. She enjoys walks with her fellow seniors and loves to stop along the way to nibble grass or watch squirrels. She loves snuggling up with Dorothy and is content to hang out wherever there’s a comfy spot to lay down. She’s great during car rides especially if her gal Dorothy is with her, they’ll both curl up in the backseat and snooze. Rose is as sweet as they come and this duo still has a lot of life and love to share with a special forever family of their own. ');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `dogs`
--
ALTER TABLE `dogs`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `dogs`
--
ALTER TABLE `dogs`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
