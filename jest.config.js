module.exports = {
  testEnvironment: 'node',
  moduleFileExtensions: ['js', 'fs', 'fsx'],
  transform: {
    '^.+\\.(fs|fsx)$': 'jest-fable-preprocessor',
    '^.+\\.js$': 'babel-jest'
  },
  testMatch: ['**/**/*Test.fs'],
  transformIgnorePatterns: ['node_modules/(?!fable.+)/'],
  coveragePathIgnorePatterns: ['packages', 'test/']
};
