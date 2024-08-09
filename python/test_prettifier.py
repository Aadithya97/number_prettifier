import unittest
from prettifier import prettify_number

class TestPrettifyNumber(unittest.TestCase):
    def test_less_than_million(self):
        self.assertEqual(prettify_number(532), "532")
    
    def test_million(self):
        self.assertEqual(prettify_number(1000000), "1M")
        self.assertEqual(prettify_number(2500000.34), "2.5M")
    
    def test_billion(self):
        self.assertEqual(prettify_number(1123456789), "1.1B")
    
    def test_trillion(self):
        self.assertEqual(prettify_number(1000000000000), "1T")

if __name__ == "__main__":
    unittest.main()
