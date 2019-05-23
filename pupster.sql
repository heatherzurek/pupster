-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:8889
-- Generation Time: May 23, 2019 at 03:55 PM
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
(11, 'Rosie', 'img/Rosie.jpg', 'Female', 'American Pit Bull Terrier Mix', 'Red/Golden/Orange/Chestnut - with White', 'Med. 26-60 lbs (12-27 kg)', 'senior', 1, 1, 'low', 1, 0, 1, 1, 1, 'The other half of the “Golden Girls” duo, Rose has the most heart warming friendship with her partner in crime Dorothy. Though this gal is a senior, her mobility is still quite good. She enjoys walks with her fellow seniors and loves to stop along the way to nibble grass or watch squirrels. She loves snuggling up with Dorothy and is content to hang out wherever there’s a comfy spot to lay down. She’s great during car rides especially if her gal Dorothy is with her, they’ll both curl up in the backseat and snooze. Rose is as sweet as they come and this duo still has a lot of life and love to share with a special forever family of their own. '),
(14, 'Angela', 'Img/Angela.jpg', 'Female', 'Shar Pei + Bull Terrier + Labrador Retriever Mix\r\n', 'Black', 'Medium', '1 Year Old', 1, 1, 'Medium', 1, 1, 1, 1, 1, 'Bask in the loving light that is canine companionship. Know that this guiding paw will be yours in friendship forever more. Sure, I am not perfect, for nothing on this wonderful planet is, but with love and patience I will blossom into a near perfect companion. I am a shy gal and am not yet willing to readily cast my affections upon an unfamiliar face, so I ask for a little patience before I relinquish my love. Children often have a hard time understanding this, so a loving forever home with kids 6+ would be my paradise. I can see the goodness in all canines and wouldn’t mind sharing a loving home with doggy friends, or kitty friends for that matter. I am proud of my crate training, and I am working to become better at it every day. Continued training should come easily, and more socialization will really help give me the confidence boost I need. If you seek the other-worldly love and friendship that only an Angelus-Canis such as I can provide, come spend some time getting to know me. '),
(15, 'Creed', 'Img/Creed.jpg', 'Male', 'Shar Pei + Bull Terrier + Labrador Retriever Mix', 'Black', 'Medium', '1 Year Old', 1, 1, 'Medium', 1, 0, 1, 1, 1, 'I sure hope that you believe in love and patience, and those beliefs will guide you. I hope that you will take action, that you will see past my nervous exterior and give me a chance to show you what a lovable little dude I am. Sure, I am very shy at first, but with time, training, and patience I will grow into a more confident boy. When I am feeling safe and secure, I am quite cuddly, very gentle, and willing to trust. I am excellent with other dogs, and each day I am learning more and more about how fun it can be to play. Meeting the cats was pretty scary, like most new things, but with time I know I will be more comfortable around them. I’d also do just fine in a family with older children who are calm and respectful. At just a year old, I am still a babe, but I have caught on to my crate training real quick, so continued training should come easy. So are you ready to take action?'),
(16, 'Elmer Fudd', 'Img/ElmerFudd.jpg', 'Male', 'Wheaten Terrier + Pit Bull Terrier Mix', 'Tan', 'Medium', '7 Years Old', 1, 1, 'Medium', 1, 0, 1, 1, 1, 'Shhh! Be vewy, vewy, quiet! I am hunting for a forever family! It’s open season on love, so I’m gonna get my quota before I miss out! This is my first time tracking down love, but I have gotten some pretty good tips from the other dogs in my play group. When we are not discussing tactics, I love to get a fun game of chase going, or maybe some fetch, if I’m lucky. I haven’t had a lot of practice, but it is still fun. Respectful and sturdy children sound like fun playmates, and I get along well with other dogs too, but a home without cats is a must. I am getting the hang of my crate training and look forward to mastering it and all the other things there are for me to learn. I have dedication, I just need direction. Like what direction do I go to find my forever love? '),
(17, 'Oslo', 'Img/Oslo.jpg', 'Male', 'American White Shepherd + Samoyed Mix', 'White', 'Large', '6 Months Old', 1, 1, 'Medium', 1, 1, 1, 1, 1, 'I’m Oslo and yes, I’m cute as could be. For a family of my own I would swim the deepest sea. And let me tell you, oh let me tell you, my heart is as big and beautiful as the sky is blue. I’m active and playful and eager to please, one tail wag from me and you’ll fall to your knees! But I do need you to work on my impulse control and mouthy behaviors so continued training is key! I enjoy sturdy, respectful children 12+, dog-savvy cats, and other dogs too. This great big world has so much to offer a young guy like me, and I’d just love to experience it all with you. Crate trained with brains and sweetness galore, you can love me a ton, but I’ll love you much more! Just give me a chance, oh give me a chance, and you’ll fall for my soul at very first glance!'),
(18, 'Presley', 'Img/Presley.jpg', 'Male', 'German Shepherd + Australian Shepherd Mix\r\n', 'Red and Black', 'Large', '1 Year Old', 1, 1, 'Medium', 1, 0, 1, 1, 1, 'I’m caught in a trap. I can’t walk out. Because I want to love you so much, baby! Why can’t you see, that we’re meant to be. It will be hard to believe at first, since I am so darn shy, but believe me, I’m fired up to find the Graceland of my dreams, complete with a forever loving family! One with other dogs, dog-savvy cats, or gentle children 8+ sounds great. So, do you have what it takes to raise a King? I’m no doubt going to need a lot of patience, time, consistency, and understanding. But we will be adorable along the way, and one day soon you’ll call me your hunka hunka burning love! But until that day, let’s have a little less conversation and a little more action, please!'),
(19, 'Humphrey', 'Img/Humphrey.jpg', 'Male', 'Bullmastiff Mix', 'Brindle with white', 'Large, 79lbs', '12 Years Old, Senior', 1, 1, 'Low', 1, 1, 1, 1, 1, 'Hi! I\'m located in Eugene, Oregon with Northwest Dog Project!'),
(20, 'Ramsey', 'Img/Ramsey.jpg', 'Male', 'American Pit Bull Terrier Mix', 'Gray + Salt and Pepper', 'Large', '9 Years Old, Senior', 1, 1, 'Low', 0, 0, 1, 1, 1, 'Hi! I\'m located in Eugene, Oregon with Northwest Dog Project!'),
(21, 'Stanley', 'Img/Stanley.jpg', 'Male', 'Chihuahua Mix\r\n', 'Black and Tan', 'Small', '9 Years Old, Senior', 1, 1, 'Low', 1, 1, 1, 1, 1, 'Meet little Stanley! This adorable guy is a young senior who has the sweetest and silliest personality, he\'s a real charmer! Stanley had been living as a stray for quite some time and was in rough shape when he first came into the rescue. Since being with us he\'s gained weight back, his skin looks a million times better and his hair has grown back in. Stanley can be a bit weary of strangers at first (mostly men) but with slow and steady introductions he warms up and will be anyone\'s best bud. Stanley does well with other dogs and currently shares his space with a cat too. Stanley loves to get out for walks, playing out in the play yard and hanging with his human buds. He will make a great addition to a mellow, loving family that wants to treat him like the little prince he is for the rest of his days! Stanley is with Northwest Dog Project, Eugene Oregon. ');

-- --------------------------------------------------------

--
-- Table structure for table `dog_score`
--

CREATE TABLE `dog_score` (
  `id` int(11) NOT NULL,
  `dog_id` int(11) NOT NULL,
  `score` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `dog_score`
--

INSERT INTO `dog_score` (`id`, `dog_id`, `score`) VALUES
(625, 1, 55),
(626, 3, 50),
(627, 5, 40),
(628, 7, 40),
(629, 9, 30),
(630, 11, 55);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `dogs`
--
ALTER TABLE `dogs`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `dog_score`
--
ALTER TABLE `dog_score`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `dogs`
--
ALTER TABLE `dogs`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `dog_score`
--
ALTER TABLE `dog_score`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=631;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
